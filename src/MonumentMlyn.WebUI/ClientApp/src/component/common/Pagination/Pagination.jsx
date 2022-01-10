import React, { useState } from 'react'
import styles from './pagination.module.css'
import cn from 'classnames'

let Paginator = ({
	totalPhotoCount,
	pageSize,
	currentPage,
	onPageChanged,
	portionSize = 10,
}) => {
	let pagesCount = Math.ceil(totalPhotoCount / pageSize)

	let pages = []
	for (let i = 1; i <= pagesCount; i++) {
		pages.push(i)
	}
	let portionCount = Math.ceil(pagesCount / portionSize)
	let [portionNumber, setPortionNumber] = useState(1)
	let leftPortionPageNumber = (portionNumber - 1) * portionSize + 1
	let rightPortionPageNumber = portionNumber * portionSize

	return (
		<div className={styles.paginator}>
			{pages
				.filter(
					(p) => p >= leftPortionPageNumber && p <= rightPortionPageNumber
				)
				.map((p) => {
					return (
						<span
							className={cn(
								{ [styles.selectedPage]: currentPage === p },
								styles.pageNumber
							)}
							key={p}
							onClick={() => {
								onPageChanged(p)
							}}
						>
							{p}
						</span>
					)
				})}
		</div>
	)
}
export default Paginator